
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseRelaInfoDA
 表名:vCoursewareResCaseRelaInfo(01120395)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:22
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
 /// v课件资源案例相关信息(vCoursewareResCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareResCaseRelaInfoDA : clsCommBase4DA
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
 return clsvCoursewareResCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareResCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareResCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareResCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable_vCoursewareResCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCaseRelaInfo.* from vCoursewareResCaseRelaInfo Left Join {1} on {2} where {3} and vCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCaseRelaInfo.* from vCoursewareResCaseRelaInfo Left Join {1} on {2} where {3} and vCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareResCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = new List<clsvCoursewareResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN();
try
{
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareResCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseRelaInfoEN.IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCaseRelaInfoEN.FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareResCaseRelaInfoEN.FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareResCaseRelaInfoEN.SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCaseRelaInfoEN.SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCaseRelaInfoEN.FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCaseRelaInfoEN.FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCaseRelaInfoEN.FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCaseRelaInfoEN.ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCaseRelaInfoEN.IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCaseRelaInfoEN.MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseRelaInfoEN.MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseRelaInfoEN.CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseRelaInfoEN.CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseRelaInfoEN.CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseRelaInfoEN.CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseRelaInfoEN.CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseRelaInfoEN.BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCaseRelaInfoEN.ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCaseRelaInfoEN.FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCaseRelaInfoEN.Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareResCaseRelaInfoEN.FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCaseRelaInfoEN.FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCaseRelaInfoEN.UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseRelaInfoEN.UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseRelaInfoEN.Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareResCaseRelaInfoEN.CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseRelaInfoEN);
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
public List<clsvCoursewareResCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = new List<clsvCoursewareResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN();
try
{
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareResCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseRelaInfoEN.IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCaseRelaInfoEN.FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareResCaseRelaInfoEN.FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareResCaseRelaInfoEN.SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCaseRelaInfoEN.SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCaseRelaInfoEN.FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCaseRelaInfoEN.FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCaseRelaInfoEN.FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCaseRelaInfoEN.ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCaseRelaInfoEN.IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCaseRelaInfoEN.MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseRelaInfoEN.MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseRelaInfoEN.CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseRelaInfoEN.CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseRelaInfoEN.CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseRelaInfoEN.CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseRelaInfoEN.CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseRelaInfoEN.BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCaseRelaInfoEN.ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCaseRelaInfoEN.FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCaseRelaInfoEN.Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareResCaseRelaInfoEN.FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCaseRelaInfoEN.FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCaseRelaInfoEN.UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseRelaInfoEN.UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseRelaInfoEN.Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareResCaseRelaInfoEN.CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareResCaseRelaInfo(ref clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objDT.Rows[0][convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdFile = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileType = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.SaveDate = objDT.Rows[0][convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileSize = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.SaveTime = objDT.Rows[0][convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileDirName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileRename = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdResource = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceID = objDT.Rows[0][convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MajorID = objDT.Rows[0][convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MajorName = objDT.Rows[0][convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CollegeID = objDT.Rows[0][convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CollegeName = objDT.Rows[0][convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CourseId = objDT.Rows[0][convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CourseCode = objDT.Rows[0][convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CourseName = objDT.Rows[0][convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.Flag = objDT.Rows[0][convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileNewName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileOldName = objDT.Rows[0][convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.UpdUser = objDT.Rows[0][convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.UpdDate = objDT.Rows[0][convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.Memo = objDT.Rows[0][convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CollegeNameA = objDT.Rows[0][convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetvCoursewareResCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN();
try
{
 objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseRelaInfoEN.ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseRelaInfoEN.CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvCoursewareResCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareResCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(), //课件资源案例流水号
CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IsVisible = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(), //课程名称
BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(), //标志
FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(), //备注
CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim() //学院名称简写
};
objvCoursewareResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN();
try
{
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareResCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseRelaInfoEN.IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCaseRelaInfoEN.FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareResCaseRelaInfoEN.FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareResCaseRelaInfoEN.SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCaseRelaInfoEN.SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCaseRelaInfoEN.FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCaseRelaInfoEN.FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCaseRelaInfoEN.FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCaseRelaInfoEN.ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCaseRelaInfoEN.IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCaseRelaInfoEN.MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseRelaInfoEN.MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseRelaInfoEN.CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseRelaInfoEN.CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseRelaInfoEN.CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseRelaInfoEN.CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseRelaInfoEN.CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseRelaInfoEN.BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCaseRelaInfoEN.ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCaseRelaInfoEN.FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCaseRelaInfoEN.Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareResCaseRelaInfoEN.FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCaseRelaInfoEN.FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCaseRelaInfoEN.UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseRelaInfoEN.UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseRelaInfoEN.Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareResCaseRelaInfoEN.CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetObjByDataRowvCoursewareResCaseRelaInfo)", objException.Message));
}
objvCoursewareResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = new clsvCoursewareResCaseRelaInfoEN();
try
{
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareResCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase = objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseRelaInfoEN.IdFile = objRow[convCoursewareResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCaseRelaInfoEN.FileName = objRow[convCoursewareResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareResCaseRelaInfoEN.FileType = objRow[convCoursewareResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareResCaseRelaInfoEN.SaveDate = objRow[convCoursewareResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileSize = objRow[convCoursewareResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCaseRelaInfoEN.SaveTime = objRow[convCoursewareResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCaseRelaInfoEN.FileDirName = objRow[convCoursewareResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCaseRelaInfoEN.FileRename = objRow[convCoursewareResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCaseRelaInfoEN.FileUpDate = objRow[convCoursewareResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCaseRelaInfoEN.FileUpTime = objRow[convCoursewareResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCaseRelaInfoEN.IdResource = objRow[convCoursewareResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCaseRelaInfoEN.ResourceID = objRow[convCoursewareResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCaseRelaInfoEN.IdResourceType = objRow[convCoursewareResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCaseRelaInfoEN.MajorID = objRow[convCoursewareResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseRelaInfoEN.MajorName = objRow[convCoursewareResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseRelaInfoEN.CollegeID = objRow[convCoursewareResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseRelaInfoEN.CollegeName = objRow[convCoursewareResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseRelaInfoEN.CourseId = objRow[convCoursewareResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseRelaInfoEN.CourseCode = objRow[convCoursewareResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseRelaInfoEN.CourseName = objRow[convCoursewareResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseRelaInfoEN.BrowseCount = objRow[convCoursewareResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCaseRelaInfoEN.ftpFileType = objRow[convCoursewareResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCaseRelaInfoEN.FileOriginName = objRow[convCoursewareResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCaseRelaInfoEN.Flag = objRow[convCoursewareResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareResCaseRelaInfoEN.FileNewName = objRow[convCoursewareResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCaseRelaInfoEN.FileOldName = objRow[convCoursewareResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCaseRelaInfoEN.UpdUser = objRow[convCoursewareResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseRelaInfoEN.UpdDate = objRow[convCoursewareResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseRelaInfoEN.Memo = objRow[convCoursewareResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareResCaseRelaInfoEN.CollegeNameA = objRow[convCoursewareResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseRelaInfoEN;
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
objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseRelaInfoEN._CurrTabName, convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseRelaInfoEN._CurrTabName, convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCoursewareResCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareResCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCaseRelaInfo", strCondition))
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
objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareResCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCoursewareResCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoENS, clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoENT)
{
objvCoursewareResCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvCoursewareResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvCoursewareResCaseRelaInfoENT.FuncModuleId = objvCoursewareResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCoursewareResCaseRelaInfoENT.FuncModuleName = objvCoursewareResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCoursewareResCaseRelaInfoENT.IdMicroteachCase = objvCoursewareResCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareResCaseRelaInfoENT.IdCoursewareResCase = objvCoursewareResCaseRelaInfoENS.IdCoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseRelaInfoENT.CoursewareResCaseName = objvCoursewareResCaseRelaInfoENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvCoursewareResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCoursewareResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCoursewareResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoENT.IsVisible = objvCoursewareResCaseRelaInfoENS.IsVisible; //是否显示
objvCoursewareResCaseRelaInfoENT.IdFile = objvCoursewareResCaseRelaInfoENS.IdFile; //文件流水号
objvCoursewareResCaseRelaInfoENT.FileName = objvCoursewareResCaseRelaInfoENS.FileName; //文件名称
objvCoursewareResCaseRelaInfoENT.FileType = objvCoursewareResCaseRelaInfoENS.FileType; //文件类型
objvCoursewareResCaseRelaInfoENT.SaveDate = objvCoursewareResCaseRelaInfoENS.SaveDate; //创建日期
objvCoursewareResCaseRelaInfoENT.FileSize = objvCoursewareResCaseRelaInfoENS.FileSize; //文件大小
objvCoursewareResCaseRelaInfoENT.SaveTime = objvCoursewareResCaseRelaInfoENS.SaveTime; //创建时间
objvCoursewareResCaseRelaInfoENT.IdFtpResource = objvCoursewareResCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvCoursewareResCaseRelaInfoENT.FtpResourceID = objvCoursewareResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCoursewareResCaseRelaInfoENT.FileOriginalName = objvCoursewareResCaseRelaInfoENS.FileOriginalName; //文件原名
objvCoursewareResCaseRelaInfoENT.FileDirName = objvCoursewareResCaseRelaInfoENS.FileDirName; //文件目录名
objvCoursewareResCaseRelaInfoENT.FileRename = objvCoursewareResCaseRelaInfoENS.FileRename; //文件新名
objvCoursewareResCaseRelaInfoENT.FileUpDate = objvCoursewareResCaseRelaInfoENS.FileUpDate; //创建日期
objvCoursewareResCaseRelaInfoENT.FileUpTime = objvCoursewareResCaseRelaInfoENS.FileUpTime; //创建时间
objvCoursewareResCaseRelaInfoENT.IdResource = objvCoursewareResCaseRelaInfoENS.IdResource; //资源流水号
objvCoursewareResCaseRelaInfoENT.ResourceID = objvCoursewareResCaseRelaInfoENS.ResourceID; //资源ID
objvCoursewareResCaseRelaInfoENT.SaveMode = objvCoursewareResCaseRelaInfoENS.SaveMode; //文件存放方式
objvCoursewareResCaseRelaInfoENT.IdResourceType = objvCoursewareResCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvCoursewareResCaseRelaInfoENT.ResourceTypeID = objvCoursewareResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCoursewareResCaseRelaInfoENT.ResourceTypeName = objvCoursewareResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCoursewareResCaseRelaInfoENT.MajorID = objvCoursewareResCaseRelaInfoENS.MajorID; //专业ID
objvCoursewareResCaseRelaInfoENT.MajorName = objvCoursewareResCaseRelaInfoENS.MajorName; //专业名称
objvCoursewareResCaseRelaInfoENT.IdXzCollege = objvCoursewareResCaseRelaInfoENS.IdXzCollege; //学院流水号
objvCoursewareResCaseRelaInfoENT.CollegeID = objvCoursewareResCaseRelaInfoENS.CollegeID; //学院ID
objvCoursewareResCaseRelaInfoENT.CollegeName = objvCoursewareResCaseRelaInfoENS.CollegeName; //学院名称
objvCoursewareResCaseRelaInfoENT.CourseId = objvCoursewareResCaseRelaInfoENS.CourseId; //课程Id
objvCoursewareResCaseRelaInfoENT.CourseCode = objvCoursewareResCaseRelaInfoENS.CourseCode; //课程代码
objvCoursewareResCaseRelaInfoENT.CourseName = objvCoursewareResCaseRelaInfoENS.CourseName; //课程名称
objvCoursewareResCaseRelaInfoENT.BrowseCount = objvCoursewareResCaseRelaInfoENS.BrowseCount; //浏览次数
objvCoursewareResCaseRelaInfoENT.ResourceOwner = objvCoursewareResCaseRelaInfoENS.ResourceOwner; //上传者
objvCoursewareResCaseRelaInfoENT.ftpFileType = objvCoursewareResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCoursewareResCaseRelaInfoENT.ftpFileSize = objvCoursewareResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCoursewareResCaseRelaInfoENT.ftpResourceOwner = objvCoursewareResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareResCaseRelaInfoENT.FileOriginName = objvCoursewareResCaseRelaInfoENS.FileOriginName; //原文件名
objvCoursewareResCaseRelaInfoENT.IsExistFile = objvCoursewareResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCoursewareResCaseRelaInfoENT.Flag = objvCoursewareResCaseRelaInfoENS.Flag; //标志
objvCoursewareResCaseRelaInfoENT.FileNewName = objvCoursewareResCaseRelaInfoENS.FileNewName; //新文件名
objvCoursewareResCaseRelaInfoENT.FileOldName = objvCoursewareResCaseRelaInfoENS.FileOldName; //旧文件名
objvCoursewareResCaseRelaInfoENT.UpdUser = objvCoursewareResCaseRelaInfoENS.UpdUser; //修改人
objvCoursewareResCaseRelaInfoENT.UpdDate = objvCoursewareResCaseRelaInfoENS.UpdDate; //修改日期
objvCoursewareResCaseRelaInfoENT.Memo = objvCoursewareResCaseRelaInfoENS.Memo; //备注
objvCoursewareResCaseRelaInfoENT.CollegeNameA = objvCoursewareResCaseRelaInfoENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FuncModuleId, 4, convCoursewareResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FuncModuleName, 30, convCoursewareResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdMicroteachCase, 8, convCoursewareResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase, 8, convCoursewareResCaseRelaInfo.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName, 100, convCoursewareResCaseRelaInfo.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdFile, 8, convCoursewareResCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileName, 500, convCoursewareResCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileType, 30, convCoursewareResCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.SaveDate, 8, convCoursewareResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileSize, 50, convCoursewareResCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.SaveTime, 6, convCoursewareResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdFtpResource, 8, convCoursewareResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FtpResourceID, 8, convCoursewareResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileOriginalName, 200, convCoursewareResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileDirName, 200, convCoursewareResCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileRename, 200, convCoursewareResCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileUpDate, 8, convCoursewareResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileUpTime, 6, convCoursewareResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdResource, 8, convCoursewareResCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ResourceID, 8, convCoursewareResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdResourceType, 4, convCoursewareResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ResourceTypeID, 4, convCoursewareResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ResourceTypeName, 50, convCoursewareResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.MajorID, 4, convCoursewareResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.MajorName, 100, convCoursewareResCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.IdXzCollege, 4, convCoursewareResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CollegeID, 4, convCoursewareResCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CollegeName, 100, convCoursewareResCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CourseId, 8, convCoursewareResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CourseCode, 20, convCoursewareResCaseRelaInfo.CourseCode);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CourseName, 100, convCoursewareResCaseRelaInfo.CourseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ResourceOwner, 50, convCoursewareResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ftpFileType, 30, convCoursewareResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ftpFileSize, 50, convCoursewareResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.ftpResourceOwner, 50, convCoursewareResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileOriginName, 500, convCoursewareResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.Flag, 50, convCoursewareResCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileNewName, 530, convCoursewareResCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.FileOldName, 530, convCoursewareResCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.UpdUser, 20, convCoursewareResCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.UpdDate, 20, convCoursewareResCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.Memo, 1000, convCoursewareResCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseRelaInfoEN.CollegeNameA, 12, convCoursewareResCaseRelaInfo.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FuncModuleId, convCoursewareResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FuncModuleName, convCoursewareResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdMicroteachCase, convCoursewareResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdCoursewareResCase, convCoursewareResCaseRelaInfo.IdCoursewareResCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName, convCoursewareResCaseRelaInfo.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convCoursewareResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdFile, convCoursewareResCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileName, convCoursewareResCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileType, convCoursewareResCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.SaveDate, convCoursewareResCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileSize, convCoursewareResCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.SaveTime, convCoursewareResCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdFtpResource, convCoursewareResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FtpResourceID, convCoursewareResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileOriginalName, convCoursewareResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileDirName, convCoursewareResCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileRename, convCoursewareResCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileUpDate, convCoursewareResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileUpTime, convCoursewareResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdResource, convCoursewareResCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ResourceID, convCoursewareResCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdResourceType, convCoursewareResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ResourceTypeID, convCoursewareResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ResourceTypeName, convCoursewareResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.MajorID, convCoursewareResCaseRelaInfo.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.MajorName, convCoursewareResCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.IdXzCollege, convCoursewareResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CollegeID, convCoursewareResCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CollegeName, convCoursewareResCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CourseId, convCoursewareResCaseRelaInfo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CourseCode, convCoursewareResCaseRelaInfo.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CourseName, convCoursewareResCaseRelaInfo.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ResourceOwner, convCoursewareResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ftpFileType, convCoursewareResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ftpFileSize, convCoursewareResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.ftpResourceOwner, convCoursewareResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileOriginName, convCoursewareResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.Flag, convCoursewareResCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileNewName, convCoursewareResCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.FileOldName, convCoursewareResCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.UpdUser, convCoursewareResCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.UpdDate, convCoursewareResCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.Memo, convCoursewareResCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseRelaInfoEN.CollegeNameA, convCoursewareResCaseRelaInfo.CollegeNameA);
//检查外键字段长度
 objvCoursewareResCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareResCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}