
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelDA
 表名:vMicroteachCase_Resource_Rel(01120370)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// v微格案例与资源关系(vMicroteachCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase_Resource_RelDA : clsCommBase4DA
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
 return clsvMicroteachCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable_vMicroteachCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel.* from vMicroteachCase_Resource_Rel Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel.* from vMicroteachCase_Resource_Rel Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
public List<clsvMicroteachCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase_Resource_Rel(ref clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdCaseType = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_RelEN.microteachCaseText = objDT.Rows[0][convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.OwnerId = objDT.Rows[0][convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_RelEN.StuName = objDT.Rows[0][convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StuID = objDT.Rows[0][convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.PoliticsName = objDT.Rows[0][convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SexDesc = objDT.Rows[0][convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCase_Resource_RelEN.EthnicName = objDT.Rows[0][convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.UniZoneDesc = objDT.Rows[0][convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_RelEN.StuTypeDesc = objDT.Rows[0][convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.CollegeName = objDT.Rows[0][convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MajorName = objDT.Rows[0][convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdGradeBase = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.GradeBaseName = objDT.Rows[0][convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdAdminCls = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.AdminClsId = objDT.Rows[0][convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.AdminClsName = objDT.Rows[0][convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Birthday = objDT.Rows[0][convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.NativePlace = objDT.Rows[0][convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Duty = objDT.Rows[0][convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IDCardNo = objDT.Rows[0][convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StuCardNo = objDT.Rows[0][convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.LiveAddress = objDT.Rows[0][convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.HomePhone = objDT.Rows[0][convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.EnrollmentDate = objDT.Rows[0][convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.PostCode = objDT.Rows[0][convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_RelEN.UserTypeId = objDT.Rows[0][convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdResource = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceName = objDT.Rows[0][convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileDirName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileRename = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileType = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdFile = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_RelEN.SaveDate = objDT.Rows[0][convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.SaveTime = objDT.Rows[0][convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FileNewName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileOldName = objDT.Rows[0][convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.UpdDate = objDT.Rows[0][convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.UpdUser = objDT.Rows[0][convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Memo = objDT.Rows[0][convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetvMicroteachCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
 objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvMicroteachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(), //姓名
StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(), //邮编
IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvMicroteachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetObjByDataRowvMicroteachCase_Resource_Rel)", objException.Message));
}
objvMicroteachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_RelEN;
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
objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_RelEN._CurrTabName, convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_RelEN._CurrTabName, convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel", strCondition))
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
objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENS, clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENT)
{
objvMicroteachCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_RelENT.FuncModuleId = objvMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelENT.FuncModuleName = objvMicroteachCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_RelENT.IdMicroteachCase = objvMicroteachCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelENT.MicroteachCaseID = objvMicroteachCase_Resource_RelENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_RelENT.MicroteachCaseName = objvMicroteachCase_Resource_RelENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_RelENT.MicroteachCaseTheme = objvMicroteachCase_Resource_RelENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_RelENT.MicroteachCaseDate = objvMicroteachCase_Resource_RelENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_RelENT.MicroteachCaseTime = objvMicroteachCase_Resource_RelENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_RelENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_RelENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_RelENT.IdStudyLevel = objvMicroteachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_RelENT.StudyLevelName = objvMicroteachCase_Resource_RelENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_RelENT.IdTeachingPlan = objvMicroteachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_RelENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_RelENT.IdCaseType = objvMicroteachCase_Resource_RelENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_RelENT.IdDiscipline = objvMicroteachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_RelENT.DisciplineID = objvMicroteachCase_Resource_RelENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_RelENT.DisciplineName = objvMicroteachCase_Resource_RelENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionID = objvMicroteachCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_RelENT.senateGaugeVersionName = objvMicroteachCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_RelENT.VersionNo = objvMicroteachCase_Resource_RelENS.VersionNo; //版本号
objvMicroteachCase_Resource_RelENT.IdTeachSkill = objvMicroteachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_RelENT.TeachSkillID = objvMicroteachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_RelENT.SkillTypeName = objvMicroteachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_RelENT.TeachSkillName = objvMicroteachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_RelENT.TeachSkillTheory = objvMicroteachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_RelENT.TeachSkillOperMethod = objvMicroteachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_RelENT.IdSkillType = objvMicroteachCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_RelENT.SkillTypeID = objvMicroteachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_RelENT.CaseLevelId = objvMicroteachCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_RelENT.microteachCaseText = objvMicroteachCase_Resource_RelENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_RelENT.OwnerId = objvMicroteachCase_Resource_RelENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_RelENT.StuName = objvMicroteachCase_Resource_RelENS.StuName; //姓名
objvMicroteachCase_Resource_RelENT.StuID = objvMicroteachCase_Resource_RelENS.StuID; //学号
objvMicroteachCase_Resource_RelENT.PoliticsName = objvMicroteachCase_Resource_RelENS.PoliticsName; //政治面貌
objvMicroteachCase_Resource_RelENT.SexDesc = objvMicroteachCase_Resource_RelENS.SexDesc; //性别名称
objvMicroteachCase_Resource_RelENT.EthnicName = objvMicroteachCase_Resource_RelENS.EthnicName; //民族名称
objvMicroteachCase_Resource_RelENT.UniZoneDesc = objvMicroteachCase_Resource_RelENS.UniZoneDesc; //校区名称
objvMicroteachCase_Resource_RelENT.StuTypeDesc = objvMicroteachCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvMicroteachCase_Resource_RelENT.IdXzCollege = objvMicroteachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_RelENT.CollegeName = objvMicroteachCase_Resource_RelENS.CollegeName; //学院名称
objvMicroteachCase_Resource_RelENT.CollegeNameA = objvMicroteachCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMicroteachCase_Resource_RelENT.IdXzMajor = objvMicroteachCase_Resource_RelENS.IdXzMajor; //专业流水号
objvMicroteachCase_Resource_RelENT.MajorName = objvMicroteachCase_Resource_RelENS.MajorName; //专业名称
objvMicroteachCase_Resource_RelENT.IdGradeBase = objvMicroteachCase_Resource_RelENS.IdGradeBase; //年级流水号
objvMicroteachCase_Resource_RelENT.GradeBaseName = objvMicroteachCase_Resource_RelENS.GradeBaseName; //年级名称
objvMicroteachCase_Resource_RelENT.IdAdminCls = objvMicroteachCase_Resource_RelENS.IdAdminCls; //行政班流水号
objvMicroteachCase_Resource_RelENT.AdminClsId = objvMicroteachCase_Resource_RelENS.AdminClsId; //行政班代号
objvMicroteachCase_Resource_RelENT.AdminClsName = objvMicroteachCase_Resource_RelENS.AdminClsName; //行政班名称
objvMicroteachCase_Resource_RelENT.Birthday = objvMicroteachCase_Resource_RelENS.Birthday; //出生日期
objvMicroteachCase_Resource_RelENT.NativePlace = objvMicroteachCase_Resource_RelENS.NativePlace; //籍贯
objvMicroteachCase_Resource_RelENT.Duty = objvMicroteachCase_Resource_RelENS.Duty; //职位
objvMicroteachCase_Resource_RelENT.IDCardNo = objvMicroteachCase_Resource_RelENS.IDCardNo; //身份证号
objvMicroteachCase_Resource_RelENT.StuCardNo = objvMicroteachCase_Resource_RelENS.StuCardNo; //学生证号
objvMicroteachCase_Resource_RelENT.LiveAddress = objvMicroteachCase_Resource_RelENS.LiveAddress; //居住地址
objvMicroteachCase_Resource_RelENT.HomePhone = objvMicroteachCase_Resource_RelENS.HomePhone; //住宅电话
objvMicroteachCase_Resource_RelENT.EnrollmentDate = objvMicroteachCase_Resource_RelENS.EnrollmentDate; //入校日期
objvMicroteachCase_Resource_RelENT.PostCode = objvMicroteachCase_Resource_RelENS.PostCode; //邮编
objvMicroteachCase_Resource_RelENT.IsDualVideo = objvMicroteachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_RelENT.UserTypeId = objvMicroteachCase_Resource_RelENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_RelENT.RecommendedDegreeId = objvMicroteachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_RelENT.RecommendedDegreeName = objvMicroteachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_RelENT.BrowseCount4Case = objvMicroteachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_RelENT.IdResource = objvMicroteachCase_Resource_RelENS.IdResource; //资源流水号
objvMicroteachCase_Resource_RelENT.ResourceID = objvMicroteachCase_Resource_RelENS.ResourceID; //资源ID
objvMicroteachCase_Resource_RelENT.ResourceName = objvMicroteachCase_Resource_RelENS.ResourceName; //资源名称
objvMicroteachCase_Resource_RelENT.SaveMode = objvMicroteachCase_Resource_RelENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_RelENT.IdFtpResource = objvMicroteachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_RelENT.FtpResourceID = objvMicroteachCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_RelENT.FileOriginalName = objvMicroteachCase_Resource_RelENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_RelENT.FileDirName = objvMicroteachCase_Resource_RelENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_RelENT.FileRename = objvMicroteachCase_Resource_RelENS.FileRename; //文件新名
objvMicroteachCase_Resource_RelENT.FileUpDate = objvMicroteachCase_Resource_RelENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_RelENT.FileUpTime = objvMicroteachCase_Resource_RelENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileSize = objvMicroteachCase_Resource_RelENS.FileSize; //文件大小
objvMicroteachCase_Resource_RelENT.FileType = objvMicroteachCase_Resource_RelENS.FileType; //文件类型
objvMicroteachCase_Resource_RelENT.ResourceOwner = objvMicroteachCase_Resource_RelENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_RelENT.IsExistFile = objvMicroteachCase_Resource_RelENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_RelENT.IdFile = objvMicroteachCase_Resource_RelENS.IdFile; //文件流水号
objvMicroteachCase_Resource_RelENT.FileName = objvMicroteachCase_Resource_RelENS.FileName; //文件名称
objvMicroteachCase_Resource_RelENT.SaveDate = objvMicroteachCase_Resource_RelENS.SaveDate; //创建日期
objvMicroteachCase_Resource_RelENT.SaveTime = objvMicroteachCase_Resource_RelENS.SaveTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileOriginName = objvMicroteachCase_Resource_RelENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_RelENT.IdResourceType = objvMicroteachCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_RelENT.ResourceTypeID = objvMicroteachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_RelENT.ResourceTypeName = objvMicroteachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_RelENT.FileNewName = objvMicroteachCase_Resource_RelENS.FileNewName; //新文件名
objvMicroteachCase_Resource_RelENT.FileOldName = objvMicroteachCase_Resource_RelENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_RelENT.ftpFileType = objvMicroteachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_RelENT.ftpFileSize = objvMicroteachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_RelENT.ftpResourceOwner = objvMicroteachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_RelENT.IsMain = objvMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objvMicroteachCase_Resource_RelENT.IdUsingMode = objvMicroteachCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_RelENT.IsVisible = objvMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objvMicroteachCase_Resource_RelENT.IndexNO = objvMicroteachCase_Resource_RelENS.IndexNO; //序号
objvMicroteachCase_Resource_RelENT.BrowseCount = objvMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_RelENT.UpdDate = objvMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objvMicroteachCase_Resource_RelENT.UpdUser = objvMicroteachCase_Resource_RelENS.UpdUser; //修改人
objvMicroteachCase_Resource_RelENT.Memo = objvMicroteachCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FuncModuleId, 4, convMicroteachCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FuncModuleName, 30, convMicroteachCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdMicroteachCase, 8, convMicroteachCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseID, 8, convMicroteachCase_Resource_Rel.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseName, 100, convMicroteachCase_Resource_Rel.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseDate, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseTime, 6, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdStudyLevel, 4, convMicroteachCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.StudyLevelName, 50, convMicroteachCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdTeachingPlan, 8, convMicroteachCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdCaseType, 4, convMicroteachCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdDiscipline, 4, convMicroteachCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.DisciplineID, 4, convMicroteachCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.DisciplineName, 50, convMicroteachCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.senateGaugeVersionID, 4, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.senateGaugeVersionName, 200, convMicroteachCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdTeachSkill, 8, convMicroteachCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.TeachSkillID, 8, convMicroteachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.SkillTypeName, 50, convMicroteachCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.TeachSkillName, 50, convMicroteachCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.TeachSkillTheory, 8000, convMicroteachCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdSkillType, 4, convMicroteachCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.SkillTypeID, 4, convMicroteachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.CaseLevelId, 2, convMicroteachCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.microteachCaseText, 8000, convMicroteachCase_Resource_Rel.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.OwnerId, 20, convMicroteachCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.StuName, 50, convMicroteachCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.StuID, 20, convMicroteachCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.PoliticsName, 30, convMicroteachCase_Resource_Rel.PoliticsName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.SexDesc, 10, convMicroteachCase_Resource_Rel.SexDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.EthnicName, 30, convMicroteachCase_Resource_Rel.EthnicName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.UniZoneDesc, 20, convMicroteachCase_Resource_Rel.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.StuTypeDesc, 50, convMicroteachCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdXzCollege, 4, convMicroteachCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.CollegeName, 100, convMicroteachCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.CollegeNameA, 12, convMicroteachCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdXzMajor, 8, convMicroteachCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.MajorName, 100, convMicroteachCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdGradeBase, 4, convMicroteachCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.GradeBaseName, 50, convMicroteachCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdAdminCls, 8, convMicroteachCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.AdminClsId, 8, convMicroteachCase_Resource_Rel.AdminClsId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.AdminClsName, 100, convMicroteachCase_Resource_Rel.AdminClsName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.Birthday, 8, convMicroteachCase_Resource_Rel.Birthday);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.NativePlace, 200, convMicroteachCase_Resource_Rel.NativePlace);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.Duty, 30, convMicroteachCase_Resource_Rel.Duty);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IDCardNo, 20, convMicroteachCase_Resource_Rel.IDCardNo);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.StuCardNo, 20, convMicroteachCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.LiveAddress, 200, convMicroteachCase_Resource_Rel.LiveAddress);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.HomePhone, 20, convMicroteachCase_Resource_Rel.HomePhone);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.EnrollmentDate, 8, convMicroteachCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.PostCode, 6, convMicroteachCase_Resource_Rel.PostCode);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.UserTypeId, 2, convMicroteachCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.RecommendedDegreeId, 2, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.RecommendedDegreeName, 30, convMicroteachCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdResource, 8, convMicroteachCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ResourceID, 8, convMicroteachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ResourceName, 100, convMicroteachCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdFtpResource, 8, convMicroteachCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FtpResourceID, 8, convMicroteachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileOriginalName, 200, convMicroteachCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileDirName, 200, convMicroteachCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileRename, 200, convMicroteachCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileUpDate, 8, convMicroteachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileUpTime, 6, convMicroteachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileSize, 50, convMicroteachCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileType, 30, convMicroteachCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ResourceOwner, 50, convMicroteachCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdFile, 8, convMicroteachCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileName, 500, convMicroteachCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.SaveDate, 8, convMicroteachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.SaveTime, 6, convMicroteachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileOriginName, 500, convMicroteachCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdResourceType, 4, convMicroteachCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ResourceTypeID, 4, convMicroteachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ResourceTypeName, 50, convMicroteachCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileNewName, 530, convMicroteachCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.FileOldName, 530, convMicroteachCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ftpFileType, 30, convMicroteachCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ftpFileSize, 50, convMicroteachCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.ftpResourceOwner, 50, convMicroteachCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.IdUsingMode, 4, convMicroteachCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.UpdDate, 20, convMicroteachCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.UpdUser, 20, convMicroteachCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_RelEN.Memo, 1000, convMicroteachCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FuncModuleId, convMicroteachCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FuncModuleName, convMicroteachCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdMicroteachCase, convMicroteachCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseID, convMicroteachCase_Resource_Rel.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseName, convMicroteachCase_Resource_Rel.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme, convMicroteachCase_Resource_Rel.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseDate, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseTime, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdStudyLevel, convMicroteachCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.StudyLevelName, convMicroteachCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdTeachingPlan, convMicroteachCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdCaseType, convMicroteachCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdDiscipline, convMicroteachCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.DisciplineID, convMicroteachCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.DisciplineName, convMicroteachCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.senateGaugeVersionID, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.senateGaugeVersionName, convMicroteachCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdTeachSkill, convMicroteachCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.TeachSkillID, convMicroteachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.SkillTypeName, convMicroteachCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.TeachSkillName, convMicroteachCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.TeachSkillTheory, convMicroteachCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod, convMicroteachCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdSkillType, convMicroteachCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.SkillTypeID, convMicroteachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.CaseLevelId, convMicroteachCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.microteachCaseText, convMicroteachCase_Resource_Rel.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.OwnerId, convMicroteachCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.StuName, convMicroteachCase_Resource_Rel.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.StuID, convMicroteachCase_Resource_Rel.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.PoliticsName, convMicroteachCase_Resource_Rel.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.SexDesc, convMicroteachCase_Resource_Rel.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.EthnicName, convMicroteachCase_Resource_Rel.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.UniZoneDesc, convMicroteachCase_Resource_Rel.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.StuTypeDesc, convMicroteachCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdXzCollege, convMicroteachCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.CollegeName, convMicroteachCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.CollegeNameA, convMicroteachCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdXzMajor, convMicroteachCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.MajorName, convMicroteachCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdGradeBase, convMicroteachCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.GradeBaseName, convMicroteachCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdAdminCls, convMicroteachCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.AdminClsId, convMicroteachCase_Resource_Rel.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.AdminClsName, convMicroteachCase_Resource_Rel.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.Birthday, convMicroteachCase_Resource_Rel.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.NativePlace, convMicroteachCase_Resource_Rel.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.Duty, convMicroteachCase_Resource_Rel.Duty);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IDCardNo, convMicroteachCase_Resource_Rel.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.StuCardNo, convMicroteachCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.LiveAddress, convMicroteachCase_Resource_Rel.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.HomePhone, convMicroteachCase_Resource_Rel.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.EnrollmentDate, convMicroteachCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.PostCode, convMicroteachCase_Resource_Rel.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.UserTypeId, convMicroteachCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.RecommendedDegreeId, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.RecommendedDegreeName, convMicroteachCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdResource, convMicroteachCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ResourceID, convMicroteachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ResourceName, convMicroteachCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdFtpResource, convMicroteachCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FtpResourceID, convMicroteachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileOriginalName, convMicroteachCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileDirName, convMicroteachCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileRename, convMicroteachCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileUpDate, convMicroteachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileUpTime, convMicroteachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileSize, convMicroteachCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileType, convMicroteachCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ResourceOwner, convMicroteachCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdFile, convMicroteachCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileName, convMicroteachCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.SaveDate, convMicroteachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.SaveTime, convMicroteachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileOriginName, convMicroteachCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdResourceType, convMicroteachCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ResourceTypeID, convMicroteachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ResourceTypeName, convMicroteachCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileNewName, convMicroteachCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.FileOldName, convMicroteachCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ftpFileType, convMicroteachCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ftpFileSize, convMicroteachCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.ftpResourceOwner, convMicroteachCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.IdUsingMode, convMicroteachCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.UpdDate, convMicroteachCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.UpdUser, convMicroteachCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_RelEN.Memo, convMicroteachCase_Resource_Rel.Memo);
//检查外键字段长度
 objvMicroteachCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}