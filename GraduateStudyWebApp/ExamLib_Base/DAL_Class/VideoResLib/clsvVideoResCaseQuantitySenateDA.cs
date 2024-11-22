
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseQuantitySenateDA
 表名:vVideoResCaseQuantitySenate(01120448)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// v视频资源量化评议(vVideoResCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvVideoResCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable_vVideoResCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseQuantitySenate.* from vVideoResCaseQuantitySenate Left Join {1} on {2} where {3} and vVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseQuantitySenate.* from vVideoResCaseQuantitySenate Left Join {1} on {2} where {3} and vVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCaseQuantitySenateEN> arrObjLst = new List<clsvVideoResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN();
try
{
objvVideoResCaseQuantitySenateEN.UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateEN.FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateEN.FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateEN.IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseQuantitySenateEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseQuantitySenateEN.OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseQuantitySenateEN.IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateEN.CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateEN.CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateEN.CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateEN.IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateEN.MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseQuantitySenateEN.MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseQuantitySenateEN.CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateEN.CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseQuantitySenateEN.CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseQuantitySenateEN.ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseQuantitySenateEN.DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseQuantitySenateEN.FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseQuantitySenateEN.LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseQuantitySenateEN.CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseQuantitySenateEN.OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseQuantitySenateEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateEN.SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateEN.SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateEN.SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateEN.SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateEN.SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateEN.BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateEN.UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateEN.UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateEN.UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateEN.UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateEN.UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseQuantitySenateEN.Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateEN.UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvVideoResCaseQuantitySenateEN.UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvVideoResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseQuantitySenateEN);
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
public List<clsvVideoResCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCaseQuantitySenateEN> arrObjLst = new List<clsvVideoResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN();
try
{
objvVideoResCaseQuantitySenateEN.UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateEN.FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateEN.FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateEN.IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseQuantitySenateEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseQuantitySenateEN.OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseQuantitySenateEN.IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateEN.CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateEN.CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateEN.CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateEN.IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateEN.MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseQuantitySenateEN.MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseQuantitySenateEN.CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateEN.CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseQuantitySenateEN.CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseQuantitySenateEN.ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseQuantitySenateEN.DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseQuantitySenateEN.FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseQuantitySenateEN.LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseQuantitySenateEN.CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseQuantitySenateEN.OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseQuantitySenateEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateEN.SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateEN.SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateEN.SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateEN.SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateEN.SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateEN.BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateEN.UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateEN.UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateEN.UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateEN.UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateEN.UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseQuantitySenateEN.Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateEN.UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvVideoResCaseQuantitySenateEN.UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvVideoResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCaseQuantitySenate(ref clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdVideoResCase = objDT.Rows[0][convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseID = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseName = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objDT.Rows[0][convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdXzMajor = objDT.Rows[0][convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.MajorID = objDT.Rows[0][convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.MajorName = objDT.Rows[0][convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CourseId = objDT.Rows[0][convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CourseCode = objDT.Rows[0][convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CourseName = objDT.Rows[0][convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseQuantitySenateEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IsShow = TransNullToBool(objDT.Rows[0][convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserId = objDT.Rows[0][convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserName = objDT.Rows[0][convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.Memo = objDT.Rows[0][convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetvVideoResCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN();
try
{
 objvVideoResCaseQuantitySenateEN.UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCaseQuantitySenateEN.IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateEN.CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseQuantitySenateEN.ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateEN.DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseQuantitySenateEN.SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateEN.SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateEN.BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateEN.UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateEN.UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvVideoResCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN()
{
UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(), //视频资源案例流水号
VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(), //视频资源案例名称
VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(), //视频资源案例主题词
VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(), //视频资源案例类型名称
VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(), //视频资源日期
VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(), //视频资源时间
VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(), //案例入库日期
VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(), //课程名称
ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()), //收藏数量
OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(), //备注
UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim() //用户类型Id
};
objvVideoResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN();
try
{
objvVideoResCaseQuantitySenateEN.UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateEN.FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateEN.FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateEN.IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseQuantitySenateEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseQuantitySenateEN.OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseQuantitySenateEN.IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateEN.CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateEN.CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateEN.CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateEN.IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateEN.MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseQuantitySenateEN.MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseQuantitySenateEN.CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateEN.CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseQuantitySenateEN.CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseQuantitySenateEN.ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseQuantitySenateEN.DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseQuantitySenateEN.FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseQuantitySenateEN.LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseQuantitySenateEN.CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseQuantitySenateEN.OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseQuantitySenateEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateEN.SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateEN.SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateEN.SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateEN.SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateEN.SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateEN.BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateEN.UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateEN.UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateEN.UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateEN.UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateEN.UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseQuantitySenateEN.Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateEN.UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvVideoResCaseQuantitySenateEN.UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetObjByDataRowvVideoResCaseQuantitySenate)", objException.Message));
}
objvVideoResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = new clsvVideoResCaseQuantitySenateEN();
try
{
objvVideoResCaseQuantitySenateEN.UserTypeName = objRow[convVideoResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateEN.FuncModuleId = objRow[convVideoResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateEN.FuncModuleName = objRow[convVideoResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateEN.IdVideoResCase = objRow[convVideoResCaseQuantitySenate.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseQuantitySenateEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenate.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenate.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseQuantitySenateEN.VideoResCaseDate = objRow[convVideoResCaseQuantitySenate.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTime = objRow[convVideoResCaseQuantitySenate.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseQuantitySenateEN.OwnerId = objRow[convVideoResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseQuantitySenateEN.IdXzCollege = objRow[convVideoResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateEN.CollegeID = objRow[convVideoResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateEN.CollegeName = objRow[convVideoResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateEN.CollegeNameA = objRow[convVideoResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateEN.IdXzMajor = objRow[convVideoResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateEN.MajorID = objRow[convVideoResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseQuantitySenateEN.MajorName = objRow[convVideoResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseQuantitySenateEN.CourseId = objRow[convVideoResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateEN.CourseCode = objRow[convVideoResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseQuantitySenateEN.CourseName = objRow[convVideoResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseQuantitySenateEN.ViewCount = objRow[convVideoResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convVideoResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseQuantitySenateEN.DownloadNumber = objRow[convVideoResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseQuantitySenateEN.FileIntegration = objRow[convVideoResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseQuantitySenateEN.LikeCount = objRow[convVideoResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseQuantitySenateEN.CollectionCount = objRow[convVideoResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseQuantitySenateEN.OwnerName = objRow[convVideoResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseQuantitySenateEN.OwnerNameWithId = objRow[convVideoResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseQuantitySenateEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateEN.SenateTheme = objRow[convVideoResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateEN.SenateContent = objRow[convVideoResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateEN.SenateDate = objRow[convVideoResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateEN.SenateTime = objRow[convVideoResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateEN.SenateIp = objRow[convVideoResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateEN.BrowseCount = objRow[convVideoResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateEN.UserId = objRow[convVideoResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateEN.UserName = objRow[convVideoResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateEN.UserKindId = objRow[convVideoResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateEN.UserKindName = objRow[convVideoResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateEN.UpdUser = objRow[convVideoResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseQuantitySenateEN.Memo = objRow[convVideoResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateEN.UpdUserName = objRow[convVideoResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvVideoResCaseQuantitySenateEN.UserTypeId = objRow[convVideoResCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateEN;
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
objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseQuantitySenateEN._CurrTabName, convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseQuantitySenateEN._CurrTabName, convVideoResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoResCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseQuantitySenate", strCondition))
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
objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoResCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateENS, clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateENT)
{
objvVideoResCaseQuantitySenateENT.UserTypeName = objvVideoResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvVideoResCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvVideoResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoResCaseQuantitySenateENT.FuncModuleId = objvVideoResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoResCaseQuantitySenateENT.FuncModuleName = objvVideoResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoResCaseQuantitySenateENT.IdMicroteachCase = objvVideoResCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvVideoResCaseQuantitySenateENT.IdVideoResCase = objvVideoResCaseQuantitySenateENS.IdVideoResCase; //视频资源案例流水号
objvVideoResCaseQuantitySenateENT.VideoResCaseID = objvVideoResCaseQuantitySenateENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseQuantitySenateENT.VideoResCaseName = objvVideoResCaseQuantitySenateENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseQuantitySenateENT.VideoResCaseTheme = objvVideoResCaseQuantitySenateENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCaseQuantitySenateENT.VideoResCaseTypeName = objvVideoResCaseQuantitySenateENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCaseQuantitySenateENT.VideoResCaseDate = objvVideoResCaseQuantitySenateENS.VideoResCaseDate; //视频资源日期
objvVideoResCaseQuantitySenateENT.VideoResCaseTime = objvVideoResCaseQuantitySenateENS.VideoResCaseTime; //视频资源时间
objvVideoResCaseQuantitySenateENT.VideoResCaseDateIn = objvVideoResCaseQuantitySenateENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCaseQuantitySenateENT.VideoResCaseTimeIn = objvVideoResCaseQuantitySenateENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCaseQuantitySenateENT.OwnerId = objvVideoResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvVideoResCaseQuantitySenateENT.IsDualVideo = objvVideoResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvVideoResCaseQuantitySenateENT.IdXzCollege = objvVideoResCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvVideoResCaseQuantitySenateENT.CollegeID = objvVideoResCaseQuantitySenateENS.CollegeID; //学院ID
objvVideoResCaseQuantitySenateENT.CollegeName = objvVideoResCaseQuantitySenateENS.CollegeName; //学院名称
objvVideoResCaseQuantitySenateENT.CollegeNameA = objvVideoResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvVideoResCaseQuantitySenateENT.IdXzMajor = objvVideoResCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvVideoResCaseQuantitySenateENT.MajorID = objvVideoResCaseQuantitySenateENS.MajorID; //专业ID
objvVideoResCaseQuantitySenateENT.MajorName = objvVideoResCaseQuantitySenateENS.MajorName; //专业名称
objvVideoResCaseQuantitySenateENT.CourseId = objvVideoResCaseQuantitySenateENS.CourseId; //课程Id
objvVideoResCaseQuantitySenateENT.CourseCode = objvVideoResCaseQuantitySenateENS.CourseCode; //课程代码
objvVideoResCaseQuantitySenateENT.CourseName = objvVideoResCaseQuantitySenateENS.CourseName; //课程名称
objvVideoResCaseQuantitySenateENT.ViewCount = objvVideoResCaseQuantitySenateENS.ViewCount; //浏览量
objvVideoResCaseQuantitySenateENT.IsShow = objvVideoResCaseQuantitySenateENS.IsShow; //是否启用
objvVideoResCaseQuantitySenateENT.DownloadNumber = objvVideoResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvVideoResCaseQuantitySenateENT.FileIntegration = objvVideoResCaseQuantitySenateENS.FileIntegration; //文件积分
objvVideoResCaseQuantitySenateENT.LikeCount = objvVideoResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvVideoResCaseQuantitySenateENT.CollectionCount = objvVideoResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvVideoResCaseQuantitySenateENT.OwnerName = objvVideoResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvVideoResCaseQuantitySenateENT.OwnerNameWithId = objvVideoResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCaseQuantitySenateENT.IdAppraiseType = objvVideoResCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvVideoResCaseQuantitySenateENT.AppraiseTypeName = objvVideoResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoResCaseQuantitySenateENT.SenateTheme = objvVideoResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoResCaseQuantitySenateENT.SenateContent = objvVideoResCaseQuantitySenateENS.SenateContent; //评价内容
objvVideoResCaseQuantitySenateENT.SenateTotalScore = objvVideoResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoResCaseQuantitySenateENT.SenateDate = objvVideoResCaseQuantitySenateENS.SenateDate; //评价日期
objvVideoResCaseQuantitySenateENT.SenateTime = objvVideoResCaseQuantitySenateENS.SenateTime; //评价时间
objvVideoResCaseQuantitySenateENT.SenateIp = objvVideoResCaseQuantitySenateENS.SenateIp; //评议Ip
objvVideoResCaseQuantitySenateENT.BrowseCount = objvVideoResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvVideoResCaseQuantitySenateENT.IdSenateGaugeVersion = objvVideoResCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseQuantitySenateENT.senateGaugeVersionID = objvVideoResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseQuantitySenateENT.senateGaugeVersionName = objvVideoResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseQuantitySenateENT.UserId = objvVideoResCaseQuantitySenateENS.UserId; //用户ID
objvVideoResCaseQuantitySenateENT.UserNameWithUserId = objvVideoResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvVideoResCaseQuantitySenateENT.UserName = objvVideoResCaseQuantitySenateENS.UserName; //用户名
objvVideoResCaseQuantitySenateENT.UserKindId = objvVideoResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvVideoResCaseQuantitySenateENT.UserKindName = objvVideoResCaseQuantitySenateENS.UserKindName; //用户类别名
objvVideoResCaseQuantitySenateENT.UpdUser = objvVideoResCaseQuantitySenateENS.UpdUser; //修改人
objvVideoResCaseQuantitySenateENT.Memo = objvVideoResCaseQuantitySenateENS.Memo; //备注
objvVideoResCaseQuantitySenateENT.UpdUserName = objvVideoResCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvVideoResCaseQuantitySenateENT.UserTypeId = objvVideoResCaseQuantitySenateENS.UserTypeId; //用户类型Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserTypeName, 20, convVideoResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.FuncModuleId, 4, convVideoResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.FuncModuleName, 30, convVideoResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdMicroteachCase, 8, convVideoResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdVideoResCase, 8, convVideoResCaseQuantitySenate.IdVideoResCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseID, 8, convVideoResCaseQuantitySenate.VideoResCaseID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseName, 100, convVideoResCaseQuantitySenate.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseTheme, 200, convVideoResCaseQuantitySenate.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName, 30, convVideoResCaseQuantitySenate.VideoResCaseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseDate, 8, convVideoResCaseQuantitySenate.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseTime, 6, convVideoResCaseQuantitySenate.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn, 8, convVideoResCaseQuantitySenate.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn, 6, convVideoResCaseQuantitySenate.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.OwnerId, 20, convVideoResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdXzCollege, 4, convVideoResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CollegeID, 4, convVideoResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CollegeName, 100, convVideoResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CollegeNameA, 12, convVideoResCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdXzMajor, 8, convVideoResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.MajorID, 4, convVideoResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.MajorName, 100, convVideoResCaseQuantitySenate.MajorName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CourseId, 8, convVideoResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CourseCode, 20, convVideoResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.CourseName, 100, convVideoResCaseQuantitySenate.CourseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.OwnerName, 30, convVideoResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.OwnerNameWithId, 51, convVideoResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdAppraiseType, 4, convVideoResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.AppraiseTypeName, 50, convVideoResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.SenateTheme, 200, convVideoResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.SenateContent, 2000, convVideoResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.SenateDate, 8, convVideoResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.SenateTime, 6, convVideoResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.SenateIp, 50, convVideoResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convVideoResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.senateGaugeVersionID, 4, convVideoResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.senateGaugeVersionName, 200, convVideoResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserId, 18, convVideoResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserNameWithUserId, 51, convVideoResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserName, 30, convVideoResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserKindId, 2, convVideoResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserKindName, 30, convVideoResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UpdUser, 20, convVideoResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.Memo, 1000, convVideoResCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UpdUserName, 20, convVideoResCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateEN.UserTypeId, 2, convVideoResCaseQuantitySenate.UserTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserTypeName, convVideoResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.FuncModuleId, convVideoResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.FuncModuleName, convVideoResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdMicroteachCase, convVideoResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdVideoResCase, convVideoResCaseQuantitySenate.IdVideoResCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseID, convVideoResCaseQuantitySenate.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseName, convVideoResCaseQuantitySenate.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseTheme, convVideoResCaseQuantitySenate.VideoResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName, convVideoResCaseQuantitySenate.VideoResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseDate, convVideoResCaseQuantitySenate.VideoResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseTime, convVideoResCaseQuantitySenate.VideoResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn, convVideoResCaseQuantitySenate.VideoResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn, convVideoResCaseQuantitySenate.VideoResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.OwnerId, convVideoResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdXzCollege, convVideoResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CollegeID, convVideoResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CollegeName, convVideoResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CollegeNameA, convVideoResCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdXzMajor, convVideoResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.MajorID, convVideoResCaseQuantitySenate.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.MajorName, convVideoResCaseQuantitySenate.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CourseId, convVideoResCaseQuantitySenate.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CourseCode, convVideoResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.CourseName, convVideoResCaseQuantitySenate.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.OwnerName, convVideoResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.OwnerNameWithId, convVideoResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdAppraiseType, convVideoResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.AppraiseTypeName, convVideoResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.SenateTheme, convVideoResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.SenateContent, convVideoResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.SenateDate, convVideoResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.SenateTime, convVideoResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.SenateIp, convVideoResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.IdSenateGaugeVersion, convVideoResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.senateGaugeVersionID, convVideoResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.senateGaugeVersionName, convVideoResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserId, convVideoResCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserNameWithUserId, convVideoResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserName, convVideoResCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserKindId, convVideoResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserKindName, convVideoResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UpdUser, convVideoResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.Memo, convVideoResCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UpdUserName, convVideoResCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateEN.UserTypeId, convVideoResCaseQuantitySenate.UserTypeId);
//检查外键字段长度
 objvVideoResCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}